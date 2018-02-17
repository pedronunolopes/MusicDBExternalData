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


public class RCt_MUArtistCorrelationRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUArtistCorrelationRecord> {

	private static final GlobalObjectKey Idt_MUArtistCorrelation = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*43GuJG9YSe0PA_LVXVvH_A");

	public static void ensureInitialized() {}
	public ENt_MUArtistCorrelationEntityRecord ssENt_MUArtistCorrelation;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUArtistCorrelationEntityRecord toStructure() {
		return ssENt_MUArtistCorrelation;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUArtistCorrelationRecord(ENt_MUArtistCorrelationEntityRecord r) throws Exception {
		ssENt_MUArtistCorrelation = (ENt_MUArtistCorrelationEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUArtistCorrelation.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUArtistCorrelation.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUArtistCorrelationRecord() {
		OptimizedAttributes = null;
		ssENt_MUArtistCorrelation = new ENt_MUArtistCorrelationEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(6, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUArtistCorrelation.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUArtistCorrelation.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUArtistCorrelation.OptimizedAttributes;
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
		index = ssENt_MUArtistCorrelation.read(r, index);
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
	public void readIM(RCt_MUArtistCorrelationRecord r) throws Exception {
		this.ssENt_MUArtistCorrelation = (ENt_MUArtistCorrelationEntityRecord) r.ssENt_MUArtistCorrelation.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MUArtistCorrelationRecord)) {
			return false;
		}
		RCt_MUArtistCorrelationRecord b = (RCt_MUArtistCorrelationRecord) obj;
		if (!this.ssENt_MUArtistCorrelation.equals(b.ssENt_MUArtistCorrelation)) return false;
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
			return super.hashCode() ^ ssENt_MUArtistCorrelation.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUArtistCorrelation.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUArtistCorrelation.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUArtistCorrelationRecord duplicate() throws Exception {
		RCt_MUArtistCorrelationRecord t = new RCt_MUArtistCorrelationRecord();
		t.ssENt_MUArtistCorrelation = (ENt_MUArtistCorrelationEntityRecord) this.ssENt_MUArtistCorrelation.duplicate();
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
			ssENt_MUArtistCorrelation.toXml(this, recordElem, "t_MUArtistCorrelation", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_muartistcorrelation")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUArtistCorrelation")) variable.setValue(ssENt_MUArtistCorrelation); else variable.setOptimized(true);
			variable.setFieldName("t_muartistcorrelation");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUArtistCorrelationRecord t = (RCt_MUArtistCorrelationRecord) super.clone();
		t.ssENt_MUArtistCorrelation = (ENt_MUArtistCorrelationEntityRecord) this.ssENt_MUArtistCorrelation.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistCorrelation.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistCorrelation.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUArtistCorrelation)) {
			return ssENt_MUArtistCorrelation;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUArtistCorrelation.fillFromOther((IRecord) other.attributeGet(Idt_MUArtistCorrelation));
	}
}
