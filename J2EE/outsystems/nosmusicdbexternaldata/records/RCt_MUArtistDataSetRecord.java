package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MUArtistDataSetRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUArtistDataSetRecord> {

	private static final GlobalObjectKey Idt_MUArtistDataSet = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*0J7lNbIiyi+EHghVZ_eTSA");

	public static void ensureInitialized() {}
	public ENt_MUArtistDataSetEntityRecord ssENt_MUArtistDataSet;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUArtistDataSetEntityRecord toStructure() {
		return ssENt_MUArtistDataSet;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUArtistDataSetRecord(ENt_MUArtistDataSetEntityRecord r) throws Exception {
		ssENt_MUArtistDataSet = (ENt_MUArtistDataSetEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUArtistDataSet.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUArtistDataSet.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUArtistDataSetRecord() {
		OptimizedAttributes = null;
		ssENt_MUArtistDataSet = new ENt_MUArtistDataSetEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUArtistDataSet.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUArtistDataSet.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUArtistDataSet.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MUArtistDataSet.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MUArtistDataSetRecord r) throws Exception {
		this.ssENt_MUArtistDataSet = (ENt_MUArtistDataSetEntityRecord) r.ssENt_MUArtistDataSet.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MUArtistDataSetRecord)) {
			return false;
		}
		RCt_MUArtistDataSetRecord b = (RCt_MUArtistDataSetRecord) obj;
		if (!this.ssENt_MUArtistDataSet.equals(b.ssENt_MUArtistDataSet)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MUArtistDataSet.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUArtistDataSet.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUArtistDataSet.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUArtistDataSetRecord duplicate() throws Exception {
		RCt_MUArtistDataSetRecord t = new RCt_MUArtistDataSetRecord();
		t.ssENt_MUArtistDataSet = (ENt_MUArtistDataSetEntityRecord) this.ssENt_MUArtistDataSet.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MUArtistDataSet.toXml(this, recordElem, "t_MUArtistDataSet", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_muartistdataset")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUArtistDataSet")) variable.setValue(ssENt_MUArtistDataSet); else variable.setOptimized(true);
			variable.setFieldName("t_muartistdataset");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUArtistDataSetRecord t = (RCt_MUArtistDataSetRecord) super.clone();
		t.ssENt_MUArtistDataSet = (ENt_MUArtistDataSetEntityRecord) this.ssENt_MUArtistDataSet.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistDataSet.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistDataSet.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUArtistDataSet)) {
			return ssENt_MUArtistDataSet;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUArtistDataSet.fillFromOther((IRecord) other.attributeGet(Idt_MUArtistDataSet));
	}
}
