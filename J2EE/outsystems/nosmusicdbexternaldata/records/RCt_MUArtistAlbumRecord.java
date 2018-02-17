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


public class RCt_MUArtistAlbumRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUArtistAlbumRecord> {

	private static final GlobalObjectKey Idt_MUArtistAlbum = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*8aXWQ6VsHxAl90GwpH9MhA");

	public static void ensureInitialized() {}
	public ENt_MUArtistAlbumEntityRecord ssENt_MUArtistAlbum;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUArtistAlbumEntityRecord toStructure() {
		return ssENt_MUArtistAlbum;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUArtistAlbumRecord(ENt_MUArtistAlbumEntityRecord r) throws Exception {
		ssENt_MUArtistAlbum = (ENt_MUArtistAlbumEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUArtistAlbum.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUArtistAlbum.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUArtistAlbumRecord() {
		OptimizedAttributes = null;
		ssENt_MUArtistAlbum = new ENt_MUArtistAlbumEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(4, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUArtistAlbum.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUArtistAlbum.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUArtistAlbum.OptimizedAttributes;
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
		index = ssENt_MUArtistAlbum.read(r, index);
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
	public void readIM(RCt_MUArtistAlbumRecord r) throws Exception {
		this.ssENt_MUArtistAlbum = (ENt_MUArtistAlbumEntityRecord) r.ssENt_MUArtistAlbum.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MUArtistAlbumRecord)) {
			return false;
		}
		RCt_MUArtistAlbumRecord b = (RCt_MUArtistAlbumRecord) obj;
		if (!this.ssENt_MUArtistAlbum.equals(b.ssENt_MUArtistAlbum)) return false;
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
			return super.hashCode() ^ ssENt_MUArtistAlbum.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUArtistAlbum.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUArtistAlbum.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUArtistAlbumRecord duplicate() throws Exception {
		RCt_MUArtistAlbumRecord t = new RCt_MUArtistAlbumRecord();
		t.ssENt_MUArtistAlbum = (ENt_MUArtistAlbumEntityRecord) this.ssENt_MUArtistAlbum.duplicate();
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
			ssENt_MUArtistAlbum.toXml(this, recordElem, "t_MUArtistAlbum", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_muartistalbum")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUArtistAlbum")) variable.setValue(ssENt_MUArtistAlbum); else variable.setOptimized(true);
			variable.setFieldName("t_muartistalbum");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUArtistAlbumRecord t = (RCt_MUArtistAlbumRecord) super.clone();
		t.ssENt_MUArtistAlbum = (ENt_MUArtistAlbumEntityRecord) this.ssENt_MUArtistAlbum.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistAlbum.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistAlbum.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUArtistAlbum)) {
			return ssENt_MUArtistAlbum;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUArtistAlbum.fillFromOther((IRecord) other.attributeGet(Idt_MUArtistAlbum));
	}
}
